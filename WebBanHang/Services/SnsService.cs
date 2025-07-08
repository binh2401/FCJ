using Amazon;
using Amazon.SimpleNotificationService;
using Amazon.SimpleNotificationService.Model;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

public class SnsService
{
    private readonly string _accessKey;
    private readonly string _secretKey;
    private readonly string _region;
    private readonly string _topicArn;

    public SnsService(IConfiguration configuration)
    {
        _accessKey = configuration["AWS:AccessKey"];
        _secretKey = configuration["AWS:SecretKey"];
        _region = configuration["AWS:Region"];
        _topicArn = configuration["AWS:SnsTopicArn"]; // 👈 thêm dòng này
    }

    public async Task SendEmailAsync(string subject, string message)
    {
        var snsClient = new AmazonSimpleNotificationServiceClient(
            _accessKey, _secretKey, RegionEndpoint.GetBySystemName(_region));

        var request = new PublishRequest
        {
            TopicArn = _topicArn,
            Subject = subject,
            Message = message
        };

        await snsClient.PublishAsync(request);
    }

}
