﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DeveloperBox.Properties {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("DeveloperBox.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性
        ///   重写当前线程的 CurrentUICulture 属性。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似 程序发生异常了，是否去GitHub提Issue？ 的本地化字符串。
        /// </summary>
        internal static string app_occur_error {
            get {
                return ResourceManager.GetString("app_occur_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 已复制到剪贴板 的本地化字符串。
        /// </summary>
        internal static string copied_to_clipboard {
            get {
                return ResourceManager.GetString("copied_to_clipboard", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Json格式化出错，可能不是合法Json串 的本地化字符串。
        /// </summary>
        internal static string json_format_error {
            get {
                return ResourceManager.GetString("json_format_error", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 消息 的本地化字符串。
        /// </summary>
        internal static string message {
            get {
                return ResourceManager.GetString("message", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 二维码解析失败，请重试 的本地化字符串。
        /// </summary>
        internal static string qrcode_decode_failed {
            get {
                return ResourceManager.GetString("qrcode_decode_failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 二维码生成出错，请重试 的本地化字符串。
        /// </summary>
        internal static string qrcode_encode_failed {
            get {
                return ResourceManager.GetString("qrcode_encode_failed", resourceCulture);
            }
        }
    }
}