
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

### 数据格式化转换

在数据绑定中，有时我们需要显示的数据与源数据不一样，如时间格式，浮点数格式，或者更复杂一些的想要一个类对象中的多个属性组合一起显示。

对于简单的数据格式化，可以通过StringFormat来处理，如时间格式化为`yyyy-MM-dd`，浮点数保留两位小数等等。其代码示例如下：

后台类：

    class SimpleDataConvert
    {
        public DateTime Date { get; set; } = DateTime.Now;
        public float Price { get; set; } = 100.123456f;
    }

使用：

    this.simpleconvert.DataContext = new SimpleDataConvert();

界面处理：

    <StackPanel x:Name="simpleconvert">
        <TextBox Text="{Binding Date,StringFormat=yyyy-MM/dd}" />
        <TextBlock Text="{Binding Price,StringFormat=f2}" />
    </StackPanel>

上述示例结果就是将Date日期格式化为`yyyy-MM/dd`；将Price保留两位小数显示。

但是有些数据显示要求无法通过StringFormat处理，则需要使用Binding的属性Converter来处理了 —— 即通过值转换器来处理。下面我们以上面用到的时间转化为例，假如我们要在前台显示`yyyyMMdd`格式的日期，此时从数据源显示到界面可以正确处理，但是在界面输入，它无法正确转化为源数据，即内置的Converter不支持，此时我们就需要自己实现值转换，示例 如下：

首先定义DateConverter，实现接口IValueConverter，代码如下：

    class DateConverter : IValueConverter
    {
        /// <summary>
        /// 数据源转界面显示
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value.GetType() == typeof(System.DateTime))
            {
                return ((System.DateTime)value).ToString("yyyyMMdd");
            }
            else
            {
                return value;
            }
        }

        /// <summary>
        /// 界面显示转数据源
        /// </summary>
        /// <param name="value"></param>
        /// <param name="targetType"></param>
        /// <param name="parameter"></param>
        /// <param name="culture"></param>
        /// <returns></returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (targetType == typeof(System.DateTime) && value != null)
            {
                DateTime dt = DateTime.Now;
                string valuestr = value.ToString();
                if (DateTime.TryParse(valuestr, out dt))
                {
                    return dt;
                }
                else if (valuestr.Length == 8)
                {
                    string yearstr = valuestr.Substring(0, 4);
                    string monthstr = valuestr.Substring(4, 2);
                    string daystr = valuestr.Substring(6, 2);
                    if (DateTime.TryParse(string.Format("{0}-{1}-{2}", yearstr, monthstr, daystr), out dt))
                    {
                        return dt;
                    }
                }
            }
            return value;
        }
    }

然后在Xaml文件中添加引用：

> 由于此处DateConvert直接定义在当前窗体类命名空间下，所以其已经默认添加了如下空间，如果定义在其他位置，则需要手动添加空间引用。

    xmlns:local="clr-namespace:Binding_Demo"

> 资源定义，以便于在控件中引用

    <Window.Resources>
        <local:DateConverter x:Key="dateconvert" />
    </Window.Resources>

最后，则将值转换器应用到控件上，代码如下：

    <TextBox Text="{Binding Date,Converter={StaticResource dateconvert}}" />

至此，一个简单的值转换器就完成了。

### 数据验证

在绑定中的验证主要设计四个属性：

* ValidatesOnDataErrors或者ValidatesOnNotifyDataErrors（WPF 4.5之后才有的）—— 与DataErrorValidationRule或NotifyDataErrorValidationRule组合使用
* ValidatesOnExceptions —— 与ExceptionValidationRule组合使用
* NotifyOnValidationError —— 控制是否触发Validation.Error事件，用于额外的内容处理
* ValidationRules —— 验证规则，用于定义验证规则集合

下面我们以异常验证规则来简要介绍验证规则的使用 —— 验证处理涉及的内容有很多，单此一节无法描述完整，故仅列举最简单的使用方式：

首先是后台类的定义：


    class ForExceptionValidate
    {
        private int max;
        public int Max
        {
            get { return max; }
            set
            {
                if (value > 100)
                {
                    throw new Exception("Max不能超过100");
                }
                max = value;
            }
        }
    }

    this.forvalidate.DataContext = new ForExceptionValidate();

然后是界面使用：

    <StackPanel x:Name="forvalidate">
        <TextBox >
            <TextBox.Text>
                <Binding Path="Max" >
                    <Binding.ValidationRules>
                        <ExceptionValidationRule></ExceptionValidationRule>
                    </Binding.ValidationRules>
                </Binding>
            </TextBox.Text>
        </TextBox>
    </StackPanel>

在此 示例 中，后台类中抛出的异常，会作为界面的验证结果来处理 —— 所以此处虽然没有明确使用异常捕获，但程序并 不会崩溃。

## 依赖属性

最后，简要说下依赖属性，所有上面的绑定基础都需要靠依赖属性。所有需要绑定功能的属性都进行了对应依赖属性（System.Windows.DependencyProperty）定义。在WPF中，我们大部分时间是在用依赖属性 —— 各种绑定，而自己的定义依赖属性的情况相对较少，所以此处就不再介绍如何定义依赖属性 —— 作为入门介绍教程。