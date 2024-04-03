## Prohibit surface projectiles 禁止地表弹幕
作者：羽学  
技术协助：熙恩、Cai、西江小子  
更新日期：2024年4月3日

## 指令  
/禁地表弹幕

## 权限
禁地表弹幕  
免检地表弹幕  

## 插件版本
1.0.3  

## 使用说明：
```
把【禁地表弹幕.dll】放【ServerPlugins文件夹】重启服务器即可生效
此版本会生成一个【禁地表弹幕表.json】在【tshock文件夹】
可通过修改【.json】文件里的ID来添加删除禁用弹幕
修改后在游戏使用这个指令重载插件配置：/reload

注意：请不要和《天顶专用版》一起装
```

## 禁止玩家在地表生成的弹幕
```
炸弹、雷管、炸药、地雷、巨石、炸弹鱼、甲虫炸弹、
仙人球、树球、世界球、火把神、弹力巨石、生命水晶巨石
沙枪弹幕：猩红沙球、腐化沙球、珍珠沙球
粘性炸弹、粘性雷管、粘性土炸弹、弹力炸弹、弹力雷管
土炸弹、干炸弹、湿炸弹、蜂蜜炸弹、熔岩炸弹
神圣溶液、腐化溶液、猩红溶液
二级榴弹、三级榴弹、四级榴弹、二级迷你榴弹、二级迷你核榴弹、
湿榴弹、熔岩榴弹、蜂蜜榴弹
二级火箭、四级火箭、干火箭、湿火箭、熔岩火箭、蜂蜜火箭、
二级雪人火箭、四级雪人火箭
二级感应雷、四级感应雷、二级迷你榴弹感应雷、干感应雷、
熔岩感应雷、蜂蜜感应雷、潮湿感应雷
二级集束火箭、二级迷你核弹火箭、二级集束破片
二级迷你核弹、二级集束榴弹、二级集束感应雷
钻头控制装置、喜庆弹射器Mk2
```

## 示例
加了这个权限可以解锁玩家的禁用：  
/group addperm default 免检地表弹幕

也可以新建一个A用户组拥有地表爆炸物使用权：  
/group add A 免检地表弹幕

且弹幕组拥有default组的所有权限：  
/group parent A default
