#!/bin/bash
#
# Run local Container
# For Development Only
#
# Run this in WSL with podman installed.  (can also use docker, but why?)
#

NAME=orgbook-app

BASEDIR=$(dirname "$0")
pushd .

cd $BASEDIR

podman build -t $NAME  --build-arg BUILD_NUMBER=9999 .

podman image prune -f

# deletes container when stopped (--rm)
podman run --rm --replace --name $NAME  -d -p 8080:8080 \
  -e hostname=$NAME $NAME

popd
