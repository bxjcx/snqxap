
Logs
-------------

###v1.1(圣建大胜利版（flag）) 2016.07.17

> - 现在鼠标移到枪娘图片上会显示该枪娘当前受到的光环加成。
> - 修改UI，看起来高大上了一点（滑稽）。
> - 修复连续开关技能导致重复叠加buff的bug。
> - 更正部分机枪的技能持续时间。 
> - 更正伤害指数不计算增加的光环暴击的错误。
> - 修改初始化时枪娘等级为100，技能等级为10。
> - 更正G36光环指向。

###v1.0.7(全年龄版（雾）) 2016.07.14

> - 采用了新的计算逻辑。现在已经可以填写1-100任意枪娘等级了。得出的数据是该等级强化完全的值。
> - 采用了新的计算逻辑。现在已经可以填写1-10任意技能等级了。
> - 手榴弹和射击的伤害均为基础伤害×倍数。
> - 更正FNC与FAMAS的光环指向、MP5的光环加成、UMP45与索米的光环影响格。

###v1.0.6(再也没见过雪球版) 2016.07.13
> - 添加敌方数据，可以参考敌方数据填敌方闪避和命中了。
> - 修改敌方回避命中初值。
> - 更正属性计算结果为整形。
> - 更正技能发动率的计算逻辑为乘法，之前为加法。
> - 更正李恩菲尔德光环无效的问题。
> - 现在已经可以在部署枪娘的时候搜索名字了。填入名字前缀自动补全。
> - - 在使用过程中请保证枪娘名字的准确性，否则计算时不会响应。
> - 再提一次：机枪在受到技能的时候在一轮之后输出大于实际。（不多）
> - - 这与软件计算秒伤的算法逻辑冲突。目前没有解决方案，请注意。

###v1.0.5(机枪加强版) 2016.07.12

> - 增加机枪输出时间slider及其相关逻辑。
> - 更正部分上一版的bug。
> - 现在部署相同的枪娘会移动该枪娘的位置。
> - 现在机枪上技能会导致全局都会收到技能加值，
> - 这将导致机枪在一轮之后输出大于实际。 ←目前还没想好怎么修改
> - 稍稍的改了一下界面。
> - 修改技能buff与光环buff叠加计算逻辑为乘法，之前为加法。

###v1.0.4(技能测试版) 2016.07.10

> - 增加谢尔久科夫的数据。
> - 录入技能数据。
> - 技能逻辑上线。
> - 增加一战消耗计算。
> - 增加每个枪娘的Q版图。（谢尔久科夫暂无）
> - 现在可以缩放窗口了。
> - 修改界面。

###v1.0.3(稳定版) 2016.07.09

> - 重写光环计算逻辑。现在可以自由的修改队伍了。
> - 缩小界面大小。
> - 修正AR小队和UMP45的光环。
> - 增加副T相关。
> - 现在ComboBox改为空有个bug，并不想在最近修。

###v1.0.2 2016.07.08

> - 增加重置按钮。
> - 部分枪娘改为中文名。
> - 更正索米buff，更正部分枪娘名称。
> - 更改光环计算逻辑，如果光环过多，还是有bug。
> - 增加"血量"栏。

###v1.0.1 2016.07.08

> - 得到demo，导入数据。

###v1.0.0 2016.07.06

> - 开始项目。
