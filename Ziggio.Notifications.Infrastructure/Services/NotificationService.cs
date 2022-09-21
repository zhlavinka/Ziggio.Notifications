using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ziggio.Notifications.Domain.Services;

namespace Ziggio.Notifications.Infrastructure.Services {
  public class NotificationService : INotificationService {
    public Task ReceiveNotificationAsync(CancellationToken cancellationToken) {
      throw new NotImplementedException();
    }

    public Task SendNotificationAsync(CancellationToken cancellationToken) {
      throw new NotImplementedException();
    }
  }
}
