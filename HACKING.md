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
        <PteroPanelIP>x.x.x.x</PteroPanelIP>
        <PteroAPIKey>ptlc_ap1k3y</PteroAPIKey>
        <PteroServerID>s3rv3r1d</PteroServerID>
        <PteroSFTPPort>2022</PteroSFTPPort>
        <PteroSFTPUser>admin</PteroSFTPUser>
        <PteroSFTPPass>supersecretpassword</PteroSFTPPass>
    </PropertyGroup>
</Project>
```

`$ dotnet build`


## Git Stuff

Creating and switching to a new branch:

`$ git switch -c <branch>`

Switching branches:

`$ git checkout <branch>`

Merging changes back to main branch (requires a clean working tree):

`$ git checkout master`
`$ git pull origin master`
`$ git merge <branch>`
`$ git push origin master`
