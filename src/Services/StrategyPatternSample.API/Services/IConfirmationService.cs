using StrategyPatternSample.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StrategyPatternSample.API.Services
{
    /// <summary>
    /// Interface métier de haut niveau
    /// </summary>
    public interface IConfirmationService
    {
        Channel Channel { get; }
        Task SendNotification(string identifiant);
    }
}
