#!/bin/sh

echo "Creating symlink for sdk-build-package to $HOME/.local/bin"
ln -sf "$(readlink -f scripts/sdk-build-package)" "$HOME/.local/bin"

echo "Done!"