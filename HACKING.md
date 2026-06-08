# Development Environment Setup

This project was initialized and is managed using `dotnet` CLI on Windows. Steps were adapted from the [documentation](https://ldm-community.github.io/docs/development-guide/getting-started/making-your-first-plugin/#making-a-plugin-from-scratch)

`$ dotnet new classlib -n Sentinel; cd Sentinel`

`$ dotnet add Sentinel.csproj reference .\libs\Assembly-CSharp.dll`

`$ dotnet new gitignore`


## Building & Testing the Plugin

Create a file `Sentinel.csproj.user` and populate it with the following (replace with your own values):
```xml
<Project>
    <PropertyGroup>
        <PteroServerID>s3rv3r1d</PteroServerID>
        <PteroSFTPURL>sftp://x.x.x.x</PteroSFTPURL>
        <PteroSFTPPort>2022</PteroSFTPPort>
        <PteroSFTPUser>admin</PteroSFTPUser>
        <PteroSFTPPass>supersecretpassword</PteroSFTPPass>
    </PropertyGroup>
</Project>
```

Build the project and upload the DLL to the test server:

`$ dotnet build`


## Git Stuff

Creating and switching to a new branch:

`$ git switch -c <branch>`

Switching branches:

`$ git checkout <branch>`

*Note: The following merge operations both require a clean working tree, or all changes to be stashed.*

Merging changes back to main branch:

`$ git checkout main`

`$ git pull origin main`

`$ git merge <branch>`

`$ git push origin main`

Merging changes from master branch into working branch:

`$ git checkout <branch>`

`$ git fetch origin`

`$ git merge origin/main`

`$ git push origin <branch>`

Deleting a branch (remote):

`$ git push origin --delete <branch>`

Deleting a branch (local):

`$ git branch -d <branch>`