using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;

// Create a dynamic assembly
AssemblyName assemblyName = new AssemblyName("DynamicLibrary");
AssemblyBuilder assemblyBuilder = AssemblyBuilder.DefineDynamicAssembly(assemblyName, AssemblyBuilderAccess.Run);

// Define a dynamic module
ModuleBuilder moduleBuilder = assemblyBuilder.DefineDynamicModule("DynamicModule");

// Define a dynamic type
TypeBuilder typeBuilder = moduleBuilder.DefineType("DynamicClass", TypeAttributes.Public);

// Define a dynamic method
MethodBuilder methodBuilder = typeBuilder.DefineMethod("DynamicMethod", MethodAttributes.Public | MethodAttributes.Static, typeof(void), null);
ILGenerator ilGenerator = methodBuilder.GetILGenerator();

// Emit IL instructions
ilGenerator.Emit(OpCodes.Ldstr, "Welcome to Transflower Dynamic Code generated using Refletion!"); // Load string onto the stack
ilGenerator.Emit(OpCodes.Call, typeof(Console).GetMethod("WriteLine", new[] { typeof(string) })); 
// Call Console.WriteLine method
ilGenerator.Emit(OpCodes.Ret);
// Return from method


// Create the type
Type dynamicType = typeBuilder.CreateType();


// Instantiate the dynamic type and invoke the method
object   instance = Activator.CreateInstance(dynamicType);
Type tt = instance.GetType();
BindingFlags flags = BindingFlags.InvokeMethod | BindingFlags.Instance |
          BindingFlags.Public | BindingFlags.Static;

tt.InvokeMember("DynamicMethod", flags, null,null,null);

Console.ReadLine();
