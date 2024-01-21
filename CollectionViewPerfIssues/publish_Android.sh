#!/bin/sh

set -e

dotnet publish \
	-f net8.0-android \
	-c Release