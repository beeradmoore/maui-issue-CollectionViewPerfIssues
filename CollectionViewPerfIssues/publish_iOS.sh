﻿#!/bin/sh

set -e

dotnet publish \
	-f net8.0-ios \
	-c Release \
	-p:ArchiveOnBuild=true \
	-p:RuntimeIdentifier=ios-arm64