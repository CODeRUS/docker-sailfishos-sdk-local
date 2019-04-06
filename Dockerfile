FROM coderus/sailfishos-platform-sdk
MAINTAINER Andrey Kozhevnikov <coderusinbox@gmail.com>

ARG local_uid
ARG local_gid

USER root

COPY sdk/sshd_config_engine /etc/ssh/sshd_config_engine
COPY sdk/start.sh /start.sh

RUN set -ex ;\
# create mersdk user with your local gid and uid to have write privileges during build \
 groupadd -g $local_gid -r mersdk ;\
 useradd -u $local_uid -g mersdk -r -m mersdk ;\
# add mersdk user to sudoers \
 chmod +w /etc/sudoers ;\
 echo "mersdk ALL=(ALL) NOPASSWD:ALL" >> /etc/sudoers ;\
 chmod -w /etc/sudoers ;\
# create missing folder \
 mkdir /home/deploy ;\
# copy sb2 targets config from nemo to mersdk user \
 cp -r /home/nemo/.scratchbox2 /home/mersdk ;\
# change ownership from default nemo user to new mersdk one \
 chown mersdk:mersdk /home/deploy ;\
 chown -R mersdk:mersdk /home/mersdk/.scratchbox2/ ;\
 find /srv/mer/targets/* -print0 | xargs -0 --max-args=1 --max-procs=16 chown -h mersdk:mersdk ;\
# transform platform sdk to application sdk \
 touch /etc/mer-sdk-vbox ;\
 rm /etc/mer-sdk-chroot ;\
# install missing packages \
 zypper ref ;\
 zypper -qn in openssh-server sdk-webapp-ts-manual sdk-webapp-sailfish sdk-webapp-bundle sdk-webapp ;\
# clear cache to save space \
 rm -rf /var/cache/zypp/* ;\
# we want debuginfo packages to be deployed to device \
 sed -i -e 's/rpms=.*/rpms=$(find RPMS -name '*.rpm' -a ! -name '*-debugsource*.rpm')/g' /usr/bin/mb2 ;\
# generate ssh server keys \
 ssh-keygen -A ;\
# make this thing working \
 chmod +x /start.sh

USER mersdk

RUN set -ex ;\
# create mersdk user with your local gid and uid to have write privileges during build \
 for t in $(sdk-assistant target list) ;\
 do \
  sb2 -t $t -m sdk-install -R groupadd -g $local_gid -r mersdk ;\
  sb2 -t $t -m sdk-install -R useradd -u $local_uid -g mersdk -r mersdk ;\
 done

CMD ["/start.sh"]
