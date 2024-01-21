#!/bin/sh

set -e

dotnet publish \
	-f net8.0-maccatalyst \
	-c Release \
	-p:MtouchLink=SdkOnly \
	-p:CreatePackage=false