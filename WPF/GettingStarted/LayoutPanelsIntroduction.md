
## 为什么要布局

布局和房子的格局具有着相似的概念，都是为了提供更好的用户体验而进行 设计。下面我们讲讲几个常用的布局面板

## 布局面板

WPF中有许多布局面板，下面将会介绍几个常用的布局面板，其中最常用的应该是Grid，StackPanel和DockPanel三大布局面板。

### Grid和UniformGrid

Grid面板在WPF界面开发中，应该是使用最多的布局面板了。其功能为**网格布局**，下面以一个例子来解释一下其功能：

    <Grid>
        <Grid.RowDefinitions>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
            <RowDefinition Height="*"/>
        </Grid.RowDefinitions>
        <Grid.ColumnDefinitions>
            <ColumnDefinition Width="*"/>
            <ColumnDefinition Width="2*"/>
            <ColumnDefinition Width="3*"/>
        </Grid.ColumnDefinitions>
    </Grid>

在本示例中，Grid布局为3行3列，其中行高采用了等分，列宽比例为1：2：3。其中行高和列宽都用到了`*`表示，这里也可以写具体的数值，或者填写`auto`。`*`和`auto`都是一种自适应的布局，不同之处在于：`*`可以说是对于外部的自适应 —— 自动填满；而`auto`可以说是对于内部的自适应 —— 最小空间占用。

在布局中处理好行列后，就可以向里面添加控件了，在使用控件时，需要为控件设置在哪一行哪一列（如，第一行第一列[从0开始]：`Grid.Row="1" Grid.Column="1"`）。

与Grid非常相似的一个面板就是UniformGrid了。虽然UniformGrid不是在Grid上继承下来的，但是在使用上可以说UniformGrid是Grid的一个特殊化处理。下面列举几点它们的区别：

* Grid需要通过RowDefinitions和ColumnDefinition来定义行和列的个数，UniformGrid只需要通过属性Rows和Columns设置
* Grid行高列宽手动设置，UniformGrid中完全等分。
* Grid中的控件必须手动指定行列，否则只能在第0行第0列；UniformGrid中自动排列。
* Grid中某行某列可以放多个控件；而在UniformGrid中必须嵌套布局面板才可以。

> Grid和UniformGrid还有其他的不同，此处不再赘述。而且相对来说，UniformGrid的使用范围较小，最有用的使用情况就是业务表单录入类的界面 —— 需要大量的网格。

### WrapPanel和StackPanel

此处之所以将WrapPanel和StackPanel放在一起，是因为他们有一定的相似之处。他们关系和上面的Grid和UniformGrid差不多，**没有继承关系**，但是StackPanel又有些像WrapPanel的特殊化处理。WrapPanel——流式布局，就像我们的写字一样，一行一行的，或者一列一列的；而StackPanel——堆栈式布局，就像一个不会换行/列的WrapPanel。下面分别说一下它们的使用场景：

WrapPanel除了上面说的写字以外，最常见的应该就是日历了，然后就是各大电商/视频网站中常会见到。而对于StackPanel，最熟悉的场景就是买票排队了，然后在应用中最常见的就是新闻列表、消息列表等（列表类内容）。如果你做的应用需要块状显示结果（多行多列），就用WrapPanel，如果需要条状展示结果（单行多列或多行单列），就用StackPanel。

> 在上述两个面板中，相对来说，StackPanel会使用的更加频繁一些。

### DockPanel

DockPanel是三大最常用面板的最后一个，与前两个相比，使用量上会相对少些。但在我们的生活当中却是最常见的，比如你家里摆放物品时，常会需要哪个哪个靠墙边放。所以这个布局会出现在最不起眼的地方，但有时却是必不可少的。它的作用是让控件靠边（上下左右）停靠，软件应用中的菜单栏是一个比较典型的应用场景。

对于DockPanel还有一点需要注意的是：**先到先得**，就是先添加的控件先占用部分位置，然后后面添加的控件在剩余部分分割空间，不影响先前的控件 —— 这里控件的前后是指xaml文件中控件定义的位置先后。

### Canvas及元素InkCanvas

Canvas是一个以坐标来确认控件位置的布局面板。在Canvas中的控件，需要以Canvas面板左上角为原点来设置坐标。相比之下，Canvas使用的会很少。只有在比较特殊的领域中，Canvas才有其展现的机会。而提到Canvas，还有一个比较特殊的元素InkCanvas，它与Canvas比较相似，但 它并不是布局面板，它直接继承自FrameworkElement；另外，InkCanvas主要用于手写 输入领域。

> 综合上述内容，Canvas的效率最高，当然它的功能也最弱；如果你去看它们的实现源码，会发现DockPanel和Canvas实现是比较简单的，所以效率也高，而Grid是最复杂的，所以它的效率相对是最低的。故在应用中选择最合适布局面板，有利于提高软件应用的性能；如果自己有能力，也可以自己实现Panel。  
> 面板性能参考：Canvas略高于DockPanel，高于WrapPanel，高于StackPanel，高于Grid —— 由源代码复杂程度大概估算，未进行详细实测。

## 常与布局组合使用的控件

在使用布局面板时，常常会需要一些辅助的控件来实现一些特殊的功能，下面会介绍几个常见的辅助控件。

### Border

Border是一个非常特殊的“控件”。它像是一个面板，但由不是；说它是个控件，它又不继承自Control，而是继承自Decorator。它常用于为面板添加边框。因为面板是不具有边框相关的属性的，如果需要在 布局中添加边框，就需要在相应的布局面板外侧添加Border，以此添加边框。而且Border不仅仅是可以添加边框，还可以处理一些圆角等处理，可以让软件应用更加圆滑。Border与布局面板还有一个主要的区别就是：

* Border内只能包含一个元素（面板、控件等），所以，想要添加多个控件，就必须先添加一个面板，然后向面板中添加控件。

### ScrollViewer

ScrollViewer也是一个常与布局组合使用的控件，与Border不同的是，它确实是一个控件（继承自Control）。用到ScrollView的原因是，布局面板本身是不提供滚动支持的，当内容超出布局面板外侧的大小限制时，我们就无法查看超出内容，此时就需要ScrollViewer来处理了。还有一点与Border相同的是，它里面也只能有一个元素，到添加多个，则必须嵌套布局面板。

### GridSplitter

看到GridSplitter名字就应该 知道它是 和Grid组合 使用的，它是用于在运行期间调整界面布局大小的。最常见的就是在左侧列表，右侧具体内容的界面布局中，需要看左侧列表的内容，但列表宽度又太小，此时，添加GridSplitter就可以让用户自己拖动来扩大列表的宽度，以便于查看更多内容。

## 附加属性

附加属性简单点说就是，这个属性不是元素（如控件）自己的，是别人给它的。最常见的使用场景就是上面的布局面板了，如Grid中，内部控件会有Grid.Column的 属性，这就是一个附加属性；还有如DockPanel中，内部控件会有DockPanel.Dock属性，这也是一个附加属性。当然，附加属性并不是外侧面板给它的，只是上面提到的两个属性，只有在相应的面板中才有效而已。

或者，在往深了说，附加属性不是真正的属性，它是一个方法调用，只是xaml中封装了方法调用，让它看起来是个属性的样子。而在个人所遇到的情况中，自定义附加属性的情况真的是很少很少 ———— 最典型的一次是使用PasswordBox，由于PasswordBox的Password不支持绑定，所以使用到了附加属性来处理，其中内容涉及到了依赖属性，此处不做详细介绍，仅做举例。

## 上述内容继承结构

<div style="width: 100%; max-width: 100%; margin-bottom:5px;"><a href="https://docs.com/smith-jess/6756/layoutpanel" title="LayoutPanel继承结构" target="_blank" style="font-family: 'Segoe UI'; font-size: 13px; text-decoration: none; margin-left:18px ">LayoutPanel继承结构</a><span style="font-family: 'Segoe UI'; font-size: 13px ">—</span><a href="https://docs.com/smith-jess" target="_blank" style="font-family: 'Segoe UI'; font-size: 13px; text-decoration: none ">Jess</a><a style="float: right; margin-bottom:5px; margin-right:18px; font-family: 'Segoe UI'; font-size: 13px; text-decoration: none " href="https://docs.com/smith-jess/6756/layoutpanel" target="_blank">Docs.com</a></div><iframe src="https://docs.com/d/embed/D25192036-0408-0710-9550-001908060826%7eM6635eff3-5641-f01f-ac6b-ffc6683826c9" frameborder="0" scrolling="no" width="100%" height="550px" style="max-width:100%" allowfullscreen="False"></iframe>