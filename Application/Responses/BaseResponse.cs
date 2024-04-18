namespace Clean.Application.Response;

public class BaseResponse
{

    public bool Success { get; set; }
    public string Message { get; set; } = string.Empty;

    public BaseResponse()
    {
        Success = true;
    }
    public BaseResponse(string message, bool success)
    {
        Success = success;
        Message = message;
    }
}
