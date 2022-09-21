using Confluent.Kafka;

namespace Ziggio.Notifications.Domain.Services {
  public interface INotificationService {
    Task ReceiveNotificationAsync(CancellationToken cancellationToken);
    Task SendNotificationAsync(CancellationToken cancellationToken);
  }
}
