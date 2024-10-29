namespace ServerCustomException.Helpers;

public class CustomErrorBoundary : ErrorBoundary
{
    [Inject]
    private IHostEnvironment? Environment { get; set; }

    protected override Task OnErrorAsync(Exception exception)
    {
        //if (Environment!.IsDevelopment())
        //    return base.OnErrorAsync(exception);
        //else
            return Task.CompletedTask;
    }
}