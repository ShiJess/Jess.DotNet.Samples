
## 绑定（Binding）元素介绍 

此处主要介绍的绑定类是`System.Windows.Data.Binding`，如果涉及其他内容，将简要介绍，不会过多说明。

下面将简要介绍最基础（最常用）的三个属性：

1. Path —— 路径，用于索引到具体的属性，常常会省略书写，示例如下：

        <TextBox Text="{Binding Path=A.B}" />

其中`Path=`可以省略，因为Binding元素含有一个带参构造函数，其参数为path。另外，示例中`A.B`需具体到属性，如果`A`已经是需要绑定的具体属性，则可以用`A`替换`A.B`。即最简单的格式是：

        <TextBox Text="{Binding A}" />

2. Mode —— 模式，用于指定数据的更新方向，它是一个枚举类型，共有一下四种方式：
    * OneTime —— 一次性更新（只更新一次），从数据源更新到当前使用的绑定属性。
    * OneWay —— 单向更新，从数据源更新到当前使用的属性。
    * OneWayToSource —— 单向更新，从当前使用的属性更新到数据源。
    * TwoWay —— 双向更新，当前属性与数据源同步。

> 注：如果未指定，即表示使用默认模式，而在不同的依赖属性上，其模式是不一样的。在使用时，如果不确定其默认模式是否是自己需要的模式时，则可以手动指定。

3. UpdateSourceTrigger —— 数据源更新触发器，用于指定控件上的属性值什么时候更新到数据源，它也是个枚举类型，有以下三种方式：
    * Explicit —— 显示更新，需要调用UpdateSource方法后才能更新。
    * LostFocus —— 失去焦点更新
    * PropertyChanged —— 属性值改变更新，大部分情况会使用此方式，但有时频繁的更新数据源会降低效率，如在TextBox中，如果数据源有较多的数据验证，此时在输入Text时，就有可能出现界面卡顿的情况。

> 注：当然，此处也有默认值设置，但不同的控件 属性的 默认 值也不一样，不过大部分情况下默认 值是PropertyChanged，比较特殊的有TextBox的Text属性，其默认值是LostFocus。

下面给一个最常用的绑定书写方式：

    <TextBox Text="{Binding A,UpdateSourceTrigger=PropertyChanged,Mode=TwoWay}" />

## 控件绑定

控件绑定，即在同一个界面中不同控件之间的数据同步处理，最常见的就是滑动条与一个文本框之间的绑定。在控件绑定中，需要指定绑定类的ElementName属性值，即当前属性绑定到哪一个控件的属性上。示例如下：

    <Slider Name="slider" Maximum="100" />
    <TextBox Text="{Binding ElementName=slider,Path=Value,UpdateSourceTrigger=PropertyChanged,Mode=TwoWay}" />

> 注：在WPF开发中，我们常常是不为控件设置Name值的，而在控件绑定中，必须为源控件添加Name属性值；而有些控件可能会不含有Name属性，此时则使用`x:Name`来指定名称。

在控件绑定中有一个比较特殊的存在——**模板绑定-TemplateBinding**，它与Binding并不在一个继承结构上。TemplateBinding是用在控件模板定义中的，用于绑定模板对应控件中的属性，示例如下：

    <TextBox x:Name="templatebinding">
        <TextBox.Template>
            <ControlTemplate TargetType="TextBox">
                <TextBlock Text="{TemplateBinding Text}" />
            </ControlTemplate>
        </TextBox.Template>
    </TextBox>

TemplateBinding可以简单理解为在Binding中设置了ElementName为其父级控件 —— 事实并非如此，仅作为辅助理解。TemplateBinding相对与Binding要少很多属性内容。

## 数据绑定

此处数据绑定表示在WPF中的对象绑定，即常见场景 就是把数据库 数据显示到 界面上。而在真实的项目开发中 ，常 会用到MVVM模式，数据绑定将会在那里体现出来，但MVVM模式开发则不在此节中叙述。

下面以一个最简单的示例解释数据绑定：

后台类 —— 数据源结构：

    class ForDataBinding
    {
        public int Count { get; set; }
    }

数据源初始化 —— 创建数据并将数据绑定到界面：

    ForDataBinding data = new ForDataBinding();
    data.Count = 10;
    this.fordatabinding.DataContext = data;

界面控件设置 —— 指定控件绑定到源数据的哪个属性：

    <Grid x:Name="fordatabinding">
        <TextBox Text="{Binding Count}" />
    </Grid>

> 其中设置了Grid的DataContext，即表示Grid内部数据上下文是以设置的数据源为基础，在此示例中，Text属性绑定的Count就是以ForDataBinding类对象为基础查找属性。 —— 即绑定路径是以当前位置以树形结构往下查找对应属性。

## 其他元素

Binding除了以上内容，还有其他的属性设置，本小节将简要介绍几个较为常用的内容。

### 数据格式化

数据格式化、

### 数据验证

简单验证

## 依赖属性

