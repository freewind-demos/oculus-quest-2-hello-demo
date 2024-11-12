# Oculus Quest 2 VR Hello World

这是一个基础的Oculus Quest 2 VR项目，展示如何在VR环境中显示3D文本"Hello World"。

## 环境准备

### 硬件要求
- Oculus Quest 2 头显
- USB-C数据线（用于连接电脑和Quest 2）
- 开发用电脑（Windows 10/11）

### 软件要求
- Unity 2022.3 LTS
- Android Studio
- Oculus开发者账号
- Oculus移动端App

## 开发环境配置

### 1. Oculus开发者账号设置
1. 访问 https://developer.oculus.com/ 注册开发者账号
2. 在手机上安装Oculus App
3. 在App中：
   - 连接你的Quest 2
   - 进入设置 > 开发者模式
   - 启用开发者模式

### 2. Unity环境配置
1. 下载并安装Unity Hub
2. 通过Unity Hub安装Unity 2022.3 LTS
   - 安装时选择"Android Build Support"
   - 包含"Android SDK & NDK Tools"
   - 包含"OpenJDK"

### 3. 项目设置
1. 克隆或下载本项目
2. 使用Unity Hub打开项目
3. 安装必要的包：
   - 打开Window > Package Manager
   - 点击"+"按钮，选择"Add package by name"
   - 添加以下包：
     * com.unity.xr.oculus
     * com.unity.textmeshpro

### 4. 构建设置
1. 打开File > Build Settings
2. 切换平台为Android（Switch Platform）
3. 在Player Settings中设置：
   - Other Settings > Package Name: com.yourcompany.vrhelloworld
   - Other Settings > Minimum API Level: Android 10.0 (API level 29)
   - Other Settings > Scripting Backend: IL2CPP
   - Other Settings > Target Architectures: ARM64

## 部署到设备

1. 用USB线连接Quest 2和电脑
2. 戴上Quest 2，在VR中允许USB调试
3. 在Unity中：
   - 确保场景中有OVRCameraRig
   - 确保HelloWorldManager脚本已添加到场景中
   - 点击Build And Run

## 项目结构

    Assets/
    ├── Scenes/
    │   └── MainScene.unity     # 主场景文件
    └── Scripts/
        └── HelloWorldManager.cs # 控制3D文本显示的脚本

## 常见问题

1. 看不到Hello World文本？
   - 检查OVRCameraRig是否正确放置
   - 确认HelloWorldManager脚本已添加到场景中的物体上

2. 无法部署到设备？
   - 确认开发者模式已开启
   - 检查USB连接
   - 在Quest 2中确认允许USB调试

3. 构建失败？
   - 确认已安装正确版本的Android Build Support
   - 检查构建设置是否正确

4. 可以在Mac上开发吗？
   - 是的，Quest 2开发支持Mac平台
   - 需要在Mac上安装：
     * Unity Editor for Mac
     * Android开发工具（通过Unity Hub安装）
   - 注意：部分Oculus开发工具在Mac上可能有功能限制，但不影响基础开发

5. 必须使用C#开发吗？
   - 不是必须的，你有以下选择：
     * Unity：主要使用C#（推荐）
     * Unreal Engine：使用C++或蓝图可视化编程
     * WebXR：使用JavaScript/TypeScript
     * Godot：支持GDScript、C#、C++
   - 推荐使用Unity + C#的原因：
     * Oculus官方支持最完善
     * 学习资源丰富
     * 开发效率高
     * C#易学习，性能好

## 许可

MIT License

## 联系方式

如有问题，请提交Issue或Pull Request。