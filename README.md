# WebAppConfigSecretsWithFW
演練Config加密

> [](https://docs.microsoft.com/zh-tw/sql/connect/jdbc/connecting-with-ssl-encryption?view=sql-server-ver15)

這是指在Config檔中，使用名文儲存資料庫連線字串，這可能使非預期使用者也能夠訪問資料庫，所以要將資料庫連線字串加密，操作方式參考[encrypt-and-decrypt-connectionstring-in-web-config-file](https://www.c-sharpcorner.com/article/encrypt-and-decrypt-connectionstring-in-web-config-file/)
<!--more-->
1. `cd C:\Windows\Microsoft.NET\Framework\v4.0.30319`
1. 加密 `.\ASPNET_REGIIS -pef "connectionStrings" "E:\Config"`
1. 解密 `.\ASPNET_REGIIS -pdf "connectionStrings" "E:\Config"`

> ASPNET_REGIIS -{pef 加密 | pdf 解密} "{加密的部份}" "{目錄路徑}"


1. 加入 RSA 金鑰容器存取權限的 `aspnet_regiis -pa "NetFrameworkConfigurationKey" "{{name}}"`
    1. name 可以使用 `System.Security.Principal.WindowsIdentity.GetCurrent().Name` 取得與確認本機的帳號

> 如果沒有執行儲存Key的指令會報錯
> ![Image](https://i.imgur.com/Ss2g7jC.png)


> 參考：
> * [DotNET網頁實驗室](https://dotblogs.com.tw/farland/2017/03/27/112926)
> * [【潛盾機】web.config連線字串加密工具](https://blog.darkthread.net/blog/web-config-connstr-encryptor-v09-cht/)
