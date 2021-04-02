#!/usr/bin/env bash

docker build -t reverseproxy .
/usr/local/bin/docker-compose up &
