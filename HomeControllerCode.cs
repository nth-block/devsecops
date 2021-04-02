//Just creating a handful of new lines of code so that Sonar treats them as new lines of code

HttpCookie cookie = new HttpCookie("aspnetwebapp", Guid.NewGuid().ToString().Replace("-", ""));
Response.AppendCookie(cookie);

AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
Random random = new Random();
aes.Mode = CipherMode.ECB;
random.NextBytes(aes.Key);
random.NextBytes(aes.IV);

//Just some more non-essential encryption to add lines of code
ICryptoTransform encryptor = aes.CreateEncryptor();
MemoryStream ms = new MemoryStream();
byte[] encrypted;
using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
{
// Create StreamWriter and write data to a stream    
using (StreamWriter sw = new StreamWriter(cs))
    sw.Write("Navneet");
encrypted = ms.ToArray();
}
ViewBag.Message = String.Format("I have encrypted Navneet to : {0}", Convert.ToBase64String(encrypted));

TripleDESCryptoServiceProvider tripledes = new TripleDESCryptoServiceProvider();
random.NextBytes(tripledes.Key);
random.NextBytes(tripledes.IV);

DESCryptoServiceProvider des = new DESCryptoServiceProvider();
random.NextBytes(des.Key);
random.NextBytes(des.IV);

SHA1CryptoServiceProvider hasher = new SHA1CryptoServiceProvider();
//
