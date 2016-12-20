
[001]: http://www.shisujie.com/blog/BeginWithHelloWorld

## 控件简介

在WPF中，严格来讲，控件是继承自System.Windows.Control类的元素。但有时我们还习惯性会将面板说成面板控件、Border说成Border控件（合理的说法应该叫***元素），不过这些，我们不会在本节中进行详细讨论，本节中将主要介绍以Control为基类的控件。

WPF中控件有很多，可以大致分为以下几类：

> 下述继承关系并不代表直接继承，有的是子类的子类等关系

* 内容控件 —— 继承自ContentControl
* 列表项控件 —— 继承自ItemsControl
* 其他控件 —— 种类相对较少的集合
    * 文本控件 —— 主要继承自TextBoxBase，有时也会将密码框PasswordBox归为此类（但PasswordBox直接继承自Control）
    * 范围控件 —— 继承自RangeBase
    * 其他 —— 直接继承自Control，以及相对偏门的控件

### 常用控件简介

在WPF中，有许多控件，下面介绍几个最常用的控件，我们以上述所列分类分别介绍。

* 内容控件
    * 按钮Button —— 使用最多的内容控件
    * 勾选框CheckBox —— 使用频率仅次于Button
    * 标签Label —— 几乎不使用（很少使用），因为有更好的替代品TextBlock，TextBlock并不是继承自Control，它直接继承自FrameworkElement，由于其实现相对简洁，占用资源较少，所以大多数情况下会使用TextBlock替代Label（只有当TextBlock的功能无法满足时，才会选择Label）。

> 内容控件中，使用Content属性设置显示的内容，而Content类型是object，所以其自由度很高。

* 列表项控件
    * 下拉框ComboBox
    * ListBox —— 简单的列表展示，其子类ListView使用的相对频繁
    * DataGrid —— 表格形式展示数据，业务系统中表格显示时常用。

> 列表项控件常用于数据列表的绑定显示。

* 文本控件
    * 文本框TextBox —— 最常用的数据录入接收控件。
    * 密码框PasswordBox —— 主要用于登录处理，它不继承自TextBoxBase，所以有时不把它归类为文本控件，自己单独一类。

* 范围控件
    * 进度条ProgressBar —— 最常用的范围控件，显示任务处理进度。
    * 滚动条ScroolBar —— 最常见的范围控件，但不常用，因为它常常是封装在ScrollViewer控件中处理。

* 其他控件
    * 日期日历控件 —— 日期选择 常会需要日期控件，但日期控件中是集成了日历控件的。


### 简单控件设置

关于控件的简单设置，可以见**Hello,World**篇中的**基本属性设置**内容：

* [WPF快速入门——Hello，World和XAML介绍][001]

## 样式设置

WPF中的样式其实和HTML中的css样式的概念是及其相似的。它其实是为了让控件的属性设置可以统一管理。当然，它还有额外的功能，最典型的就是触发器。下面说下样式的定义和使用。

样式可以定义在许多不同的位置，它可以直接定义在对应的控件中，如下：

    <Button Content="样式设置">
        <Button.Style>
            <Style TargetType="Button">
                <Setter Property="Background" Value="Red" />
            </Style>
        </Button.Style>
    </Button>

当然，这种用法并不建议，因为它失去了统一管理的优势，除非是控件有定制化需求，一般不会这样写。针对上面的内容，我们可以将样式抽取出来，然后将样式放置到当前窗体的样式列表中，然后在控件上使用样式，方法如下：

> 首先将样式定义到当前窗体的Window.Resources中

    <Window.Resources>
        <Style x:Key="winbtn" TargetType="Button">
            <Setter Property="Background" Value="Blue" />
        </Style>
    </Window.Resources>

> 然后在相应的控件上应用样式

    <Button Content="样式设置2" Style="{StaticResource winbtn}"></Button>

到这，我们就可以在当前窗体中使用统一样式了。但是如果你的应用含有多个窗体 页面时，需要统一样式，这样就不够了，所以我们需要使用资源字典来管理我们的样式，方法如下：

> 首先在项目上右键，点击**添加**-**资源字典**，然后再资源字典中定义样式，代码如下：

    <ResourceDictionary xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
                        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                        xmlns:local="clr-namespace:Control_Style_Template">
        <Style x:Key="stylebtn" TargetType="Button">
            <Setter Property="Background" Value="Yellow" />
        </Style>
    </ResourceDictionary>

> 此时，样式还未生效，我们需要将样式的资源字典加载到应用中使用，即将样式资源字典添加到App.xaml中，代码如下：

    <Application.Resources>
        <ResourceDictionary Source="/StyleDictionary.xaml" />
    </Application.Resources>

> 最后，将样式应用到控件中，上面将 资源字典引用添加到App.xaml中，说明整个应用都可以使用这个资源字典，所以在窗体中使用时如下：

    <Button Content="样式设置3" Style="{StaticResource stylebtn}" />

至此，样式最基本的使用方式就讲完了，下面简要描述一下样式中各个关键字的意义。

样式的基本结构：

    <Style x:Key="标识" TargetType="对应的控件类型">
        <Setter Property="属性名称" Value="属性值" />
    </Style>

使用结构：

    <控件类型 Style="{StaticResource 标识key}" />

> Tips：
>
> * 其中`x:key`是用于标识样式名称，如果将其省略，则表示此样式为默认样式，即不需要你手动为控件添加Style，默认使用此样式 —— 需要注意，保证默认样式（相同控件）最多只有一个；
> * 其中Value的类型是object，所以它可以采用复杂属性设置，内容见Hello,World。
> * 其中样式引用使用StaticResource，还可以使用DynamicResource（相对占用资源较多）—— 它们具体的区别本节不做讨论。


### 触发器

触发器为我们极大的简化了界面逻辑的书写，它主要包含三大类：简单的Trigger —— 主要处理属性变化、DataTrigger —— 数据绑定变化触发、EventTrigger —— 事件触发器。其中前两个可以进一步细分 —— 单个和多个。下面简要介绍下简单的触发器和事件触发器：

#### 简单的触发器

简单的触发器使用Trigger和MultiTrigger来实现，它们是使用的最为频繁的触发器。其效果是当一个或多个属性发生改变时，改变 其他的一个或多个属性的值。示例如下：

> 示例效果：鼠标悬停，字体绿色；鼠标悬停并按下，字体白色：

    <Style.Triggers>
        <Trigger Property="IsMouseOver" Value="True">
            <Setter Property="Foreground" Value="Green" />
        </Trigger>
        <MultiTrigger >
            <MultiTrigger.Conditions>
                <Condition Property="IsPressed" Value="True" />
                <Condition Property="IsMouseOver" Value="True" />
            </MultiTrigger.Conditions>
            <Setter Property="Margin" Value="1" />
            <Setter Property="Foreground" Value="White" />
        </MultiTrigger>
    </Style.Triggers>

其中的MultiTrigger中的Setter设置也可以套在MultiTrigger.Setters之内，如下：

    <MultiTrigger.Setters>
        <Setter Property="Margin" Value="1" />
        <Setter Property="Foreground" Value="White" />
    </MultiTrigger.Setters>

> 此处使用前景色做触发示例，而未选择背景色，因为背景色的MouseOver是无效的，原因是其内部使用ButtonChrome样式，需要利用模板处理才可以正确修改。

#### 事件触发器

事件触发器由具体的事件引发。其主要用于动画的处理，其他情况使用的较少。关于动画的制作本节不做描述。

## 模板设置

WPF在界面设计中最强大的部分应该就是模板了。它可以让你将一个勾选框改成一个按钮的样子，或者将方形按钮改成圆形按钮，等等。模板的定义和使用方式基本 和样式 一样，可以在控件内定义、也可以抽取出来定义到资源字典中。

WPF中模板主要有三种类型，ControlTemplate、DataTemplate和ItemsPanelTemplate，在本文中，将只介绍控件模板ControlTemplate，熟悉了控件模板，其他的两个大概也就会用了，况且另外两个相对与控件模板使用的要少一些。

下面是控件模板最简单的使用：定义+使用

    <ControlTemplate x:Key="txt" TargetType="TextBox">
        <TextBlock Text="{TemplateBinding Text}"></TextBlock>
    </ControlTemplate>

    <TextBox Text="控件模板" Template="{StaticResource txt}" />

当然，个人并不建议上面的定义方式，上面是直接自己写控件模板，但这样就丢失了默认模板的一些特点和功能（如上面的模板就让TextBox无法显示光标，无法定位输入位置），我更建议利用IDE来自动生成模板，因为这样会带有原始的默认模板，而以此模板进行修改可以保证功能不丢失。当然，也不能过于依赖自动生成的内容，因为其内容相对冗余，自己可以进行精简。

以现有模板为基础创建新的模板步骤：

* 方法1：右击控件，选择**编辑模板**-**编辑副本**。 —— 此法缺陷是有些控件默认是创建样式，然后在样式中定义模板内容。当然这也可以说是个好处，样式模板一起处理了。
* 方法2：在**属性**面板中搜索*template*，然后点击**Template**属性后的方块，选中**转换为新资源**即可。 —— 此法操作起来较为麻烦。

> 一般情况下，都是使用方法1，即样式模板一起定义。

下面代码简要展示一个TextBox添加一个内置的标签：—— 以原生模板简单修改

    <ControlTemplate x:Key="TextBoxControlTemplate1" TargetType="{x:Type TextBox}">
        <Border x:Name="border" BorderBrush="{TemplateBinding BorderBrush}" BorderThickness="{TemplateBinding BorderThickness}" Background="{TemplateBinding Background}" SnapsToDevicePixels="True">
            <DockPanel>
                <TextBlock DockPanel.Dock="Left" Text="内置标签:"></TextBlock>
                <ScrollViewer x:Name="PART_ContentHost" Focusable="False" HorizontalScrollBarVisibility="Hidden" VerticalScrollBarVisibility="Hidden"/>
            </DockPanel>
        </Border>
        <ControlTemplate.Triggers>
            <Trigger Property="IsEnabled" Value="False">
                <Setter Property="Opacity" TargetName="border" Value="0.56"/>
            </Trigger>
            <Trigger Property="IsMouseOver" Value="True">
                <Setter Property="BorderBrush" TargetName="border" Value="#FF7EB4EA"/>
            </Trigger>
            <Trigger Property="IsKeyboardFocused" Value="True">
                <Setter Property="BorderBrush" TargetName="border" Value="#FF569DE5"/>
            </Trigger>
        </ControlTemplate.Triggers>
    </ControlTemplate>

关于控件的模板内容其实有很多，此处不再详述。