### 项目信息

![](https://github.com/chen365409389/SoftwareLicense/blob/master/Img/REG.png)

#### 用于进行软件授权

示例中使用了一组RSA密钥，实际项目中需要使用RSAKey生成新的密钥来使用<br>

#### 使用方式<br>
1.取消注释Generator项目中FrmGenerate.cs第37、38行内容，在39行添加断点，运行Generator项目<br>
2.调用rsa.RSAKey方法后将生成一组密钥，私钥及对应的公钥，进行记录<br>
3.替换私钥到Generator项目中FrmGenerate.cs的privateKey内容<br>
4.替换公钥到Register项目中Validate.cs的publicKey内容<br>
5.可以使用Generator和Register对自己的项目(Client测试)添加授权验证了<br><br>
#### 验证流程<br>
1.客户端从本地key.lic文件中读取授权信息<br>
2.使用RSA公钥对授权信息进行签名验证<br>
3.判断机器码是否与授权机器码一致<br>
4.比对授权时间与本机时间是否过期<br>
5.完成验证进入程序，未完成验证显示机器码提示注册<br><br>
#### 授权流程<br>
1.通过客户端机器码、授权时间等生成字串<br>
2.使用密钥对字串进行签名<br>
3.将签名信息和授权信息合并后整体转Base64<br>
4.将Base64字串发送给客户端<br><br>

#### 客户端调用示例
请对Register进行签名，防止程序替换
```C#

    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            //进行授权验证
            if (!Validate.Check())
                return;
            //进行授权验证(无弹框模式)
            //if (!Validate.Check(false))
            //    return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain());
        }
    }
    
```
JackChen<br>
2018-04-17
