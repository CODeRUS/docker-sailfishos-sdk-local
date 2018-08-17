#!/bin/bash
DIR="$( cd "$( dirname "${BASH_SOURCE[0]}" )" >/dev/null && pwd )"
export PATH="$DIR/helper:$PATH"
$HOME/SailfishOS/bin/qtcreator >/dev/null &