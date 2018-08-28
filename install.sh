#!/bin/sh

echo "Creating symlink for sdk-build-package to $HOME/.local/bin/"
echo "Don't forget to check your $PATH"
mkdir -p "$HOME/.local/bin"
ln -sf "$(readlink -f scripts/sdk-build-package)" "$HOME/.local/bin"

echo "Done!"
