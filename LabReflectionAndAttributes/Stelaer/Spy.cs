using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string name, params string[] fieldsName)
        {
            Type type = Type.GetType(name);
            Object obj = Activator.CreateInstance(type, new object[] { });
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Class under investigation: {type.FullName}");
            FieldInfo[] fieldInfos = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            foreach (var field in fieldInfos.Where(x => fieldsName.Contains(x.Name)))
            {
                sb.AppendLine($"{field.Name} = {field.GetValue(obj)}");
            }
            return sb.ToString().Trim();

        }
    }
}
