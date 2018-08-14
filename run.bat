set SDKDIR=C:\SailfishOS

docker run --rm -it ^
 --cap-add SYS_PTRACE ^
 -p 2222:2222 ^
 -p 8080:8080 ^
 --volume "%userprofile%:/home/mersdk/share" ^
 --volume "%userprofile%:/home/src1" ^
 --volume "%SDKDIR%\mersdk\ssh:/etc/ssh/authorized_keys" ^
 --volume "%SDKDIR%\mersdk\targets:/host_targets" ^
 --volume "%SDKDIR%\vmshare:/etc/mersdk/share" ^
 "sailfishos-platform-sdk-local" ^
 %*
