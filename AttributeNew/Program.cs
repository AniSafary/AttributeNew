using AttributeNew;
using System;
using System.Reflection;


AttributeUse instance = new AttributeUse();

Type type = typeof(AttributeUse);

MethodInfo[] method = type.GetMethods(BindingFlags.Public|BindingFlags.Instance
                                        |BindingFlags.NonPublic|BindingFlags.DeclaredOnly);


foreach (var item in method)
{

    object[] attr = item.GetCustomAttributes(typeof(AttributeCustom), false);
    if (attr != null)
    {
        Console.WriteLine("Method    "+item.Name);
        for (int i = 0; i < attr.Length; i++)
        {
            AttributeCustom item1 = (AttributeCustom)attr[i];
            Console.WriteLine("attribut   " + item1.PositionalString);
            Console.WriteLine("Call Method");
            item.Invoke(instance, null);
            Console.WriteLine();
        }
    }
    
}
