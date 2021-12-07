# DynamicPInvokeFactory
DllImport DllImportAttribute.
## How To Use
### Example
```
public delegate int MessageBoxEx(IntPtr ptr, string text, string caption, uint type);
public static MessageBoxEx MessageBox = DynamicPInvokeFactory.GetPInvokeMethod<MessageBoxEx>("user32");
```
1. Create the delegate the same as the method to import.
2. Declare the delegate field as static like example.
3. Finish.
