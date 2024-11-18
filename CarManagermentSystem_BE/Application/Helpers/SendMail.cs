using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace Application.Helpers
{
    public static class SendMail
    {
        public static async Task<bool> SendConfirmationEmail(string toMail, string confirmLink)
        {
            string userName = "";
            var emailFrom = "";
            var password = "";
            string templateMail = @"<!DOCTYPE html>
<html lang='vi'>
<head>
  <meta charset='UTF-8'>
  <meta name='viewport' content='width=device-width, initial-scale=1.0'>
  <title>Xác Nhận Địa Chỉ Email</title>
  <style>
    body {
      font-family: Arial, sans-serif;
      margin: 0;
      padding: 0;
      background-color: #f8f8f8;
      color: #333;
    }

    .email-container {
      width: 100%;
      max-width: 600px;
      margin: 0 auto;
      background-color: #ffffff;
      padding: 20px;
      border-radius: 8px;
      box-shadow: 0 4px 10px rgba(0, 0, 0, 0.1);
    }

    .email-header {
      text-align: center;
      padding-bottom: 20px;
      border-bottom: 2px solid #dcdcdc;
    }

    .email-header img {
      width: 150px;
    }

    .email-body {
      margin-top: 20px;
      font-size: 16px;
      line-height: 1.5;
      color: #333;
    }

    .button-container {
      text-align: center;
      margin-top: 30px;
    }

    .button {
      background-color: #e12d39; /* Màu đỏ */
      color: white;
      font-size: 18px;
      padding: 12px 30px;
      border-radius: 5px;
      text-decoration: none;
      display: inline-block;
      transition: background-color 0.3s ease;
    }

    .button:hover {
      background-color: #c02029; /* Màu đỏ đậm khi hover */
    }

    .footer {
      text-align: center;
      font-size: 14px;
      color: #777;
      margin-top: 40px;
    }

    .footer a {
      color: #e12d39;
      text-decoration: none;
    }

    .footer a:hover {
      text-decoration: underline;
    }
  </style>
</head>
<body>
  <div class='email-container'>
    <div class='email-header'>
      <img src='https://gudlogo.com/wp-content/uploads/2019/04/logo-xe-may-35-1030x509.jpg' alt='Logo Cửa Hàng Xe Máy' />
      <h2>Xác Nhận Địa Chỉ Email</h2>
    </div>

    <div class='email-body'>
      <p>Chào bạn,</p>
      <p>Cảm ơn bạn đã đăng ký tại cửa hàng xe máy của chúng tôi. Để hoàn tất quá trình đăng ký, vui lòng xác nhận địa chỉ email của bạn bằng cách nhấn vào nút dưới đây.</p>
      <p><strong>Nhấn vào nút dưới đây để xác nhận email của bạn:</strong></p>
    </div>

    <div class='button-container'>
      <a href='https://example.com/verify-email?token=uniqueToken123' class='button'>Xác Nhận Email</a>
    </div>

    <div class='footer'>
      <p>Nếu bạn không thực hiện đăng ký này, xin vui lòng bỏ qua email này.</p>
      <p>Cảm ơn bạn đã tin tưởng và lựa chọn cửa hàng xe máy của chúng tôi!</p>
      <p>Truy cập website của chúng tôi tại: <a href='#'>www.cuahangxemay.com</a></p>
    </div>
  </div>
</body>
</html>
";

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress(userName, emailFrom));
            message.To.Add(new MailboxAddress("", toMail));
            message.Subject = "Confirmation Mail";
            message.Body = new TextPart("html")
            {
                Text = templateMail
            };
            using (var client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);

                client.Authenticate(emailFrom, password);

                try
                {
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                    return true;
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                    return false;
                }
            }
        }
    }
}
