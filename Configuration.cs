﻿using Newtonsoft.Json;
using Terraria;
using TShockAPI;

namespace 禁地表弹幕
{
    public class Configuration
    {
        public static readonly string FilePath = Path.Combine(TShock.SavePath, "禁地表弹幕表.json");
        // 新增配置项：地表下禁止弹幕的高度阈值（单位：游戏格子）
        public string 配置说明1 = "(注意：颠倒和正常地表只能开启一个，高度阈值数值649为1倍 正常种子：大世界10384（16倍）";
        public string 配置说明2 = "(颠倒地图种子：小世界25960（40倍）中世界31476（48.5倍） 大世界35370（54.5倍）";
        public bool 启用 { get; set; } = true;
        public bool 开启正常高度限制 { get; set; } = true;
        public int 正常限制高度阈值 { get; set; } = (int)(Main.worldSurface * 16);
        public bool 开启颠倒高度限制 { get; set; } = false;
        public int 颠倒限制高度阈值 { get; set; } = (int)(Main.worldSurface * 40);
        public int[] 禁用地表弹幕id = new int[] { 28, 29, 37, 65, 68, 99, 108, 136, 137, 138, 139, 142, 143, 144, 146, 147, 149, 164, 339, 341, 354, 453, 516, 519, 637, 716, 718, 727, 773, 780, 781, 782, 783, 784, 785, 786, 787, 788, 789, 790, 791, 792, 796, 797, 798, 799, 800, 801, 804, 805, 806, 807, 809, 810, 863, 868, 869, 904, 905, 906, 910, 911, 949, 1013, 1014 };
 
        // 添加一个新的方法来获取带有名称的列表
        public Dictionary<int, string> GetIdsWithNames()
        {
            var dict = new Dictionary<int, string>();

            foreach (var id in 禁用地表弹幕id)
            {
                string name = (string)Terraria.Lang.GetProjectileName(id);

                // 检查出现名字为ProjectileName. 时替换为“未知”
                if (name.StartsWith("ProjectileName."))
                {
                    name = "未知";
                }

                dict[id] = name;
            }
            return dict;
        }

        public void Write(string path)
        {
            using (var fs = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            {
                var str = JsonConvert.SerializeObject(this, Formatting.Indented);
                using (var sw = new StreamWriter(fs))
                {
                    sw.Write(str);
                }
            }
        }

        public static Configuration ReadOrCreateDefault(string path)
        {
            if (!File.Exists(path))
            {
                var defaultConfig = new Configuration();
                defaultConfig.Write(path);
                return defaultConfig;
            }

            using (var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                using (var sr = new StreamReader(fs))
                {
                    var cf = JsonConvert.DeserializeObject<Configuration>(sr.ReadToEnd());
                    return cf!;
                }
            }
        }
    }
}