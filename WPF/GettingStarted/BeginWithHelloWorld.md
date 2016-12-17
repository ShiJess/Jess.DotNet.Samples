
[001]: ../Resources/NewHelloWorld.png
[002]: https://github.com/ShiJess/DotNetStudySamples/raw/master/WPF/Resources/NewHelloWorld.png

> 个人开发环境 —— 按个人喜好选择：  
> * IDE：Visual Studio Community 2015 —— 愿意尝鲜的可以试下VS2017
> * System：Windows 8.1

## Hello World

尽管hello，world的例子已经用烂了，但你不可否认它所带来的无限魅力。如果你去查找hello，world起源，会发现许多有趣的事。所以本文仍以hello，world为例开始我们的WPF学习之旅。

### 创建第一个WPF项目

**操作步骤**：打开**Visual Studio** —— 依次点击**文件-新建-项目** —— 在弹出的**新建项目**对话框中的索引目录区域选择**已安装-模板-Visual C#-Windows** —— 选中对话框列表项中的**WPF 应用程序** —— 在对话框下方的名称中输入名称**Hello_World** —— 点击**确定**完成项目创建。

![创建Hello，World项目][002]

### 项目结构说明

* 解决方案Hello_World —— VS解决方案，可以用于同时管理多个项目
    * Hello_World —— 项目，即刚刚新建的Hello，World项目
        * Properties —— 项目属性相关内容设置，包括程序集信息、一些资源等内容
        * 引用 —— 项目中需要的依赖程序集
        * App.config —— 项目配置，在**此**Hello，World项目中可有可无。
        * App.xaml —— 含两个文件App.xaml和App.xaml.cs；此部分功能主要是设置应用的启动窗体及一些样式资源的引用，常用于主窗体显示前的一些准备工作设置。
        * MainWindow.xaml —— 含有两个文件MainWindow.xaml和MainWindow.xaml.cs；.xaml文件为界面设计文件，.cs文件为后台代码文件

> Tips：全局异常处理

为了避免应用出现异常后直接退出，我们常会需要添加一个全局的异常捕获处理。处理方法为，在App.xaml.cs中重载OnStartup方法，为DispatcherUnhandleException事件添加处理内容。代码如下：

    protected override void OnStartup(StartupEventArgs e)
    {
        this.DispatcherUnhandledException += App_DispatcherUnhandledException;
        
        base.OnStartup(e);
    }

    private void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
    {
        //throw new NotImplementedException();
        e.Handled = true;
    }

注意：在事件处理中添加你自己的实现内容，可以添加对话框提示等。如果有些异常处理完后，不需要应用退出，则将e.Handled设置为true；如果此处为致命错误，必须退出应用软件，则e.Handled保留原来的false。

## XAML基础介绍

XAML文件是以.xaml为后缀的XML文件。其是为了简化UI的创建过程而推出的。它不仅仅在WPF中应用，在微软后续的UMP开发中也是利用此技术进行UI处理。

> 注：XAML读音为“zammel”

### 命名空间说明

在XAML文件中，命名空间利用xmlns（xml namespace）来引入。命名空间引入基本格式为：

    xmlns:别名="命名空间"

其中默认命名空间可以省略“冒号”和“别名”，另，此处引用的命名空间与cs代码中的还有所不同，cs代码中只能一个空间一个空间引入，而此处的空间可以是多个命名空间的集合 —— URL表示，当然也可以一个一个空间引入。

### 类对应关系

在我们的示例中MainWindow.xaml根节点Window上有一个属性设置“x:Class”，此属性设置了其所对应的C#代码类。而在我们的MainWindow.xaml.cs的定义中，可以看到MainWindow类含有partial（分部类）修饰符。其实在最终的生成结果中，他们是同一个类，我们可以在`obj\Debug`目录下看到 MainWindow.g.i.cs文件，它是在生成过程中的一个中间状态，从其内容结构上可以看出它也是MainWindow的一个分部类。如果将XAML文件中的类名修改，程序生成过程就会出现错误，因为MainWindow构造函数 中 的`InitializeComponent()`方法是xaml文件生成出来的。

> 注：分部类 —— 就是让你可以将一个类的内容定义到多个文件。—— 据我所知，这应该是.NET中特有的设计 。

## 基本属性及事件

属性设置其实和在cs代码中设置一样，仅仅是因为换了种写法，封装了一些处理而已。

### 简单的属性设置

简单属性设置，即可以用一个字符串表示的属性设置，如Name属性。还有就是一些位置Alignment的设置，如HorizontalAlignment可以设置为Center，在XAML文件中，Center是一个字符串，而在类中HorizontalAlignment是一个System.Windows.HorizontalAlignment的枚举类型的属性，所以此处就封装了字符串到Alignment枚举类型的一个转换。不过在我们界面设置的时候，是不太需要关注这一块的。

> 注：许多控件的Text或Content属性会与标签值（如`<a>此处为标签值</a>`）冲突 —— 即它们表示同一个属性，所以为了避免冲突，建议，可以直接设置Text或Content的值时，尽量设置在属性上设置，避免在标签中设置属性值。

    // 建议
    <TextBox Text="hello"></TextBox>
    <Button Content="hello"></Button>

    // 不建议
    <TextBox >hello</TextBox>
    <Button >hello</Button>

虽然效果一样，但看得不爽 —— 强迫症。如下方式也是可以的，主要用于复杂的属性设置：

    <TextBox >
        <TextBox.Text>hello</TextBox.Text>
    </TextBox>
    <Button >
        <Button.Content>hello</Button.Content>
    </Button>

### 复杂属性设置

复杂属性的设置表现在无法用一个字符串表示的情况，如颜色背景设置，但我们是单色的情况时，可以直接用一个字符串表示，但是当需要设置渐变色时，就无法一个值表示，所以需要多行语句来表示。

以下为背景色的渐变色设置，其位置变化为默认值，从左上角到右下角渐变：

    <Button >
        <Button.Content>hello</Button.Content>
        <Button.Background>
            <LinearGradientBrush>
                <LinearGradientBrush.GradientStops>
                    <GradientStop Offset="0" Color="Red"></GradientStop>
                    <GradientStop Offset="1" Color="Blue"></GradientStop>
                </LinearGradientBrush.GradientStops>
            </LinearGradientBrush>
        </Button.Background>
    </Button>

还有一些属性相关内容，将在后面介绍，如附加属性，资源设置等。

### 添加事件

事件的添加有两种方式，一种是直接在XAML文件中和写属性一样添加 —— 利用自动创建，在后台代码中创建事件的实现。还有一种是在后台代码手动实现。写法纯粹看个人喜好了。

当然，后台代码手动实现的自由度更高一些，如某些事件的注册可能需要在界面加载完后注册会更好一些。个人是推荐在后台代码自己手动加，虽然写的时候会麻烦些，但可以自己整理的比较清晰一些。

> Tips：学WPF的好处  
> * 就本节内容而言，WPF界面设计采用xml格式，以后以此基础学习网页设计和Android开发会相对简单一些。