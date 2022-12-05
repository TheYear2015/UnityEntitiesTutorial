# ECS 教程

>原文
>
>https://github.com/Unity-Technologies/EntityComponentSystemSamples/blob/master/DOTS_Guide/ecs_tutorial/README.md

## 概述

本教程将逐步创建一个非常简单的项目，介绍基本的 DOTS 概念。

## Unity 版本

教程使用的是 **2022.2.0b16**。

## 创建项目

![](images/unity_hub.png)


1. 使用 3D （URP） 模板在 Unity Hub 创建新项目。
2. 项目第一次打开时, 点击 "URP Empty Template" inspector 中的按钮 "Remove Readme Assets" 。用来删除不需要的目录 "Assets/TutorialInfo" 。
3. 我们需要添加一个 package  。其他依赖的 packages 将会自动一起添加 。`Window > Package Manager` , 点击左上角的 `+` 按钮，并选择 "Add package by name" 。在 "Name" 里填写 "com.unity.entities.graphics"，"Version" 保持空白。点击 "Add" 按钮。我们就只需要等待 package 安装完成。

    ![](images/add_package_by_name.png)
4. 在 `Edit > Project Settings > Editor`, 勾选 "Enter Play Mode Options" ，不要勾选 reload 子选项 `Reload Domain` 和 `Reload Scene` 。

    ![](images/enter_play_mode_settings.png)

5. 在 Project window 中，在 Assets 目录下创建以下没有的目录:
    * Prefabs
    * Scenes (already created)
    * Scripts/Aspects
    * Scripts/Authoring
    * Scripts/Components
    * Scripts/MonoBehaviours
    * Scripts/Systems
    * Settings (already created)

    ![](images/assets_folders.png)

## 修改设置

> 设置 baking pipeline 属性。

设置 "Scene View Mode" 属性 (`Preferences/Entities`) 为 "Runtime Data" 。

![](images/conversion_settings.png)

## 第一步 制作场景

1. 打开 Scenes 目录下的 SampleScene 。

2. Hierarchy 窗口中, 右键点击选择 `New Subscene > Empty Scene...` 。命名为 "EntityScene" ，把文件保存在 `Scenes/SampleScene` 目录。

![](images/create_subscene.png)

3. 右键点击 Hierarchy window 中的 "EntityScene" ，选择创建一个新的 GameObject `GameObject > 3D Object > Cube` 命名为 "Tank" 。设置它的 Position 为 (0,0,0) ， Rotation 为 (0,0,0) ，Scale 为 (1,1,1) 。

4. 右键点击 Hierarchy window 中的 "Tank" ，选择创建一个新的 GameObject `3D Object > Sphere` 命名为 "Turret" 。设置它的 **Position** 为 (0,0.5,0) ，**Rotation** 为 (45,0,0) ，Scale 为 (1,1,1) 。

5. 右键点击 Hierarchy window 中的 "Turret"  ，选择创建一个新的 GameObject `3D Object > Cylinder` 命名为 "Cannon" 。设置它的 **Position 为 (0,0.5,0)** ，Rotation 为 (0,0,0) ，**Scale** 为 (0.2,0.5,0.2) 。

6. 右键点击 Hierarchy window 中的 "Cannon" ，选择创建一个新的 GameObject `Create Empty` 命名为 "SpawnPoint" 。设置它的 **Position** 为 (0,1,0) ，**Rotation** 为 (-90,0,0) ，Scale 为 (1,1,1) 。

7. 我们会得到和下图相似的结果。<p>
![](images/tank_hierarchy.png)

8. 需要删除节点对象中的碰撞体。<p>
![](images/remove_component.png)
