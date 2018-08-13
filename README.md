# Scripts and helpers for building packages and images using dockerized Platform SDK

## TLDR

1. Run `build.sh`
2. Image tagged `sailfishos-platform-sdk-local` will be generated
3. Run `install.sh`
4. Command `sdk-build-package` will be added to your PATH
5. To start container build engine run `run.sh`

## Summary

Dockerfile contains instructions to create a new user called `mersdk` inside new image
called `sailfishos-platform-sdk-local` which is based on `coderus/sailfishos-platform-sdk`
with your current iser UID and GID to have permissions to save build artifacts to the
current folder.

Additionally there are handy helpers to execute rpm build (mb2) build operations.

## Build

You must have Docker installed and started.

1. Check out the project

```git clone https://github.com/CODeRUS/docker-sailfishos-sdk-local```

2. Place yourself in the root of the checked project

```cd docker-sailfishos-sdk-local```

3. Run the build script

```./build.sh```

3. Run the installer script

```./install.sh```

## Extra

This image can be used to work with Sailfish OS SDK instead on virtual machine

Run `run.sh` to start build engine. It will start container with ssh server running on port `2222` and web server on `8080`.

## Credits

- [EvilJazz](https://github.com/evilJazz/sailfishos-buildengine) for the inspiration
- [SfietKonstantin](https://github.com/SfietKonstantin/docker-sailfishos-sdk) for the initial version of scripts
