#!/bin/bash

USERDIR=$(eval echo ~$USER)
SDK=$USERDIR/SailfishOS2

IMAGE_NAME="sailfishos-platform-sdk-local"

docker run --rm -it \
    --cap-add SYS_PTRACE \
    --network=host \
    --volume "$USERDIR:/home/mersdk/share" \
    --volume "$USERDIR:/home/src1" \
    --volume "$SDK/mersdk/ssh:/etc/ssh/authorized_keys" \
    --volume "$SDK/mersdk/targets:/host_targets" \
    --volume "$SDK/vmshare:/etc/mersdk/share" \
    "$IMAGE_NAME" \
    "$@"