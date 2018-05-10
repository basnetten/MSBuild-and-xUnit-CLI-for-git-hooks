
### MSBuild-and-xUnit-CLI-for-git-hooks

A little script that tests whether a .sln builds, and whether the xUnit unit tests run. Made to work with git-hooks.
Checkout the pre-commit.sample file for an example.
This script makes use of a .env file.
If the .env file is not present, the .env.example file will be copied and used.