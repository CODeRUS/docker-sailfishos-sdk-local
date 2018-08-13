#!/bin/sh

docker build \
    --build-arg local_uid=$(id -u $USER) \
    --build-arg local_gid=$(id -g $USER) \
    -t sailfishos-platform-sdk-local .
