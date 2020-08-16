# Unity3D_Solar-System-Simulation

[![standard-readme compliant](https://img.shields.io/badge/readme%20style-standard-brightgreen.svg?style=flat-square)](https://github.com/RichardLitt/standard-readme)

A simple solar system simulation made by Unity3D.

## Table of Contents

- [Background](#Background)
- [Exhibition](#Exhibition)
- [Install](#install)
- [Usage](#usage)
- [Structure](#Structure)
- [Maintainers](#Maintainers)
- [License](#license)

## Background
This is a very simple solar system simulation made by Unity3D according to the [Michigan State University](https://msu.edu/)'s coursera course [Introduction to Game Development](https://www-cloudfront-alias.coursera.org/learn/game-development/home/welcome).

## Exhibition

![Solar System](https://github.com/Yunxiang-Li/Unity3D_Simple-Solar-System-Simulation/blob/master/Screeshots%20and%20Gifs/Solar%20System%20Exhibition.gif)

![Solar System](https://github.com/Yunxiang-Li/Unity_Simple-Solar-System-Simulation/blob/master/Screeshots%20and%20Gifs/syloar%20system.PNG)

## Install

I use Unity2018.2.19 and JetBrain's Rider IDE for this project under Windows 10 environment.<br>
[Unity and Unity hub download](https://unity3d.com/get-unity/download)<br>
[archived Unity download ](https://unity3d.com/get-unity/download/archive)<br>
[Jetbrains Rider download](https://www.jetbrains.com/rider/download/#section=windows)


## Usage

1. Download this repo, open(or zip and open) the **Unity_Simple-Solar-System-Simulation** folder.

2. Open the **Unity Hub**, from the Home Screen, click **Projects** to view the **Projects** tab.

3. To open an existing Unity Project stored on your computer, click the Project name in the **Projects** tab, or click **Open** to browse your computer for the Project folder.

4. Note that a Unity Project is a collection of files and directories, rather than just one specific Unity Project file. To open a Project, you must select the main Project folder, rather than a specific file).

5. For this game, just select the **Unity_Simple-Solar-System-Simulation** folder and open this project.

## Structure

The whole project in Unity contains two main folders, **Assets** folder and **Package** folder.<br>
Under **Assets** folder, there are altogether **6** subfolders:

1. Materials folder: contains all **11** materials need for each planet and the universe.

2. Plugins folder: Plugins/Editor/JetBrains, creates for JetBrains Rider IDE.

3. Scences folder: contains the main scence(Solar System) of the project.

4. Scripts folder: contains all **3** C# scripts. RotateAround script for letting each planet
to rotate(both rotation and revolution),FollowAtTarget script for setting camera to follow a 
target object through aiming at its positive z axis and ChangeLookAtTarget script for setting
camera to look at another target object when we click the left mouse button upon that target object.

5. Sounds folder: contains all **3** sounds files of each planet.

6. Textures folder: contains all **13** textures for each planet and the universe.


## Maintainers

[@Yunxiang-Li](https://github.com/Yunxiang-Li).

## License

[MIT license](https://github.com/Yunxiang-Li/CS61B/blob/master/LICENSE)
