using Godot;
using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;

namespace JiangHGodot.Mod
{
    public class ModItem
    {
        public string path { get; private set; }
        public Dictionary<string, PackedScene> scenes = new Dictionary<string, PackedScene>();

        private string pckPath => $"{path}/mod.zip";
        private string tscnPathBegin => $"mods/{System.IO.Path.GetFileName(path)}";

        public ModItem(string path)
        {
            GD.Print($"Load mod:{path} start!");

            this.path = path;

            using (ZipArchive archive = ZipFile.OpenRead(pckPath))
            {
                foreach (ZipArchiveEntry entry in archive.Entries.Where(x=>x.Name.EndsWith(".tscn")))
                {
                    GD.Print($"ZipContent:{entry.FullName}");

                    if(entry.FullName.StartsWith("addons"))
                    {
                        continue;
                    }

                    if(!entry.FullName.StartsWith(tscnPathBegin))
                    {
                        throw new Exception($"Load {entry.FullName} error, file must start with {tscnPathBegin}");
                    }

                    scenes.Add(entry.FullName, null);
                }
            }
        }

        public void LoadPack()
        {
            if (!ProjectSettings.LoadResourcePack(pckPath))
            {
                GD.PrintErr($"Load pck:{pckPath} failed!");
            }

            GD.Print($"Load mod:{path} finish!");
        }

        public PackedScene LoadScene(string scenePath)
        {
            var key = $"{tscnPathBegin}/scenePath";
            return (PackedScene)ResourceLoader.Load("res://mods/native/Main.tscn");
        }
    }
}