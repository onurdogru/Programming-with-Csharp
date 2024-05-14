// Decompiled with JetBrains decompiler
// Type: EsdTurnikesi.Ayarlar
// Assembly: EsdTurnikesi, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: C8099926-BBEB-495E-ADF6-36B4F5F75BE8
// Assembly location: C:\Users\serkan.baki\Desktop\esd-rar\ESD\Release\EsdTurnikesi.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.IO.Ports;
using System.Runtime.CompilerServices;

namespace ProgrammingStation
{
    [CompilerGenerated]
    [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed class Prog_Ayarlar : ApplicationSettingsBase
    {
        private static Prog_Ayarlar defaultInstance = (Prog_Ayarlar)SettingsBase.Synchronized((SettingsBase)new Prog_Ayarlar());

        private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
        {
        }

        private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
        {
        }

        public static Prog_Ayarlar Default
        {
            get
            {
                return Prog_Ayarlar.defaultInstance;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string iniDosyaYolu
        {
            get
            {
                return (string)this[nameof(iniDosyaYolu)];
            }
            set
            {
                this[nameof(iniDosyaYolu)] = (object)value;
            }
        }


        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1299")]
        public string adminSifre
        {
            get
            {
                return (string)this[nameof(adminSifre)];
            }
            set
            {
                this[nameof(adminSifre)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1453")]
        public string kaliteSifre
        {
            get
            {
                return (string)this[nameof(kaliteSifre)];
            }
            set
            {
                this[nameof(kaliteSifre)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string projectName
        {
            get
            {
                return (string)this[nameof(projectName)];
            }
            set
            {
                this[nameof(projectName)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("C:\\Users\\serkan.baki\\Desktop\\MIND-BATCH-FILES\\")]
        public string Logdosyayolu
        {
            get
            {
                return (string)this[nameof(Logdosyayolu)];
            }
            set
            {
                this[nameof(Logdosyayolu)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("Kitaplıklar\\Belgeler\\logpersonel.accdb")]
        public string E8PNGdosyayolu
        {
            get
            {
                return (string)this[nameof(E8PNGdosyayolu)];
            }
            set
            {
                this[nameof(E8PNGdosyayolu)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("Kitaplıklar\\Belgeler\\logpersonel.accdb")]
        public string E9PNGdosyayolu
        {
            get
            {
                return (string)this[nameof(E9PNGdosyayolu)];
            }
            set
            {
                this[nameof(E9PNGdosyayolu)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("Kitaplıklar\\Belgeler\\logpersonel.accdb")]
        public string E945PNGdosyayolu
        {
            get
            {
                return (string)this[nameof(E945PNGdosyayolu)];
            }
            set
            {
                this[nameof(E945PNGdosyayolu)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("Kitaplıklar\\Belgeler\\logpersonel.accdb")]
        public string E10PNGdosyayolu
        {
            get
            {
                return (string)this[nameof(E10PNGdosyayolu)];
            }
            set
            {
                this[nameof(E10PNGdosyayolu)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("1000")]
        public int timerAdmin
        {
            get
            {
                return (int)this[nameof(timerAdmin)];
            }
            set
            {
                this[nameof(timerAdmin)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxSuccess
        {
            get
            {
                return (bool)this[nameof(chBoxSuccess)];
            }
            set
            {
                this[nameof(chBoxSuccess)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxError1
        {
            get
            {
                return (bool)this[nameof(chBoxError1)];
            }
            set
            {
                this[nameof(chBoxError1)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxError2
        {
            get
            {
                return (bool)this[nameof(chBoxError2)];
            }
            set
            {
                this[nameof(chBoxError2)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("true")]
        public bool chBoxError3
        {
            get
            {
                return (bool)this[nameof(chBoxError3)];
            }
            set
            {
                this[nameof(chBoxError3)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string successBatch
        {
            get
            {
                return (string)this[nameof(successBatch)];
            }
            set
            {
                this[nameof(successBatch)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string error1Batch
        {
            get
            {
                return (string)this[nameof(error1Batch)];
            }
            set
            {
                this[nameof(error1Batch)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string error2Batch
        {
            get
            {
                return (string)this[nameof(error2Batch)];
            }
            set
            {
                this[nameof(error2Batch)] = (object)value;
            }
        }

        [UserScopedSetting]
        [DebuggerNonUserCode]
        [DefaultSettingValue("")]
        public string error3Batch
        {
            get
            {
                return (string)this[nameof(error3Batch)];
            }
            set
            {
                this[nameof(error3Batch)] = (object)value;
            }
        }
    }
}
