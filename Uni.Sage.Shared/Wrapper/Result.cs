using System.Collections.Generic;
using System.Threading.Tasks;

namespace Uni.Sage.Shared.Wrapper
{
    public interface IResult
    {
        List<string> Messages { get; set; }
        List<string> Errors { get; set; }

        bool Succeeded { get; set; }
    }

    public interface IResult<out T> : IResult
    {
        T Data { get; }
    }

    public class Result : IResult
    {
        public Result()
        {
        }

        public List<string> Messages { get; set; } = new List<string>();
        public List<string> Errors { get; set; } = new List<string>();

        public bool Succeeded { get; set; }


        public static IResult Fail()
        {
            return new Result { Succeeded = false };
        }

        public static IResult Fail(string error)
        {
            return new Result { Succeeded = false, Errors = new List<string> { error } };
        }

        public static IResult Fail(Exception ex)
        {
            return new Result { Succeeded = false, Errors = new List<string> { ex.ToString() } };
        }

        public static IResult Fail(List<string> errors)
        {
            return new Result { Succeeded = false, Messages = errors };
        }

        public static Task<IResult> FailAsync()
        {
            return Task.FromResult(Fail());
        }

        public static Task<IResult> FailAsync(string error)
        {
            return Task.FromResult(Fail(error));
        }

        public static Task<IResult> FailAsync(List<string> errors)
        {
            return Task.FromResult(Fail(errors));
        }

        public static Task<IResult> FailAsync(Exception ex)
        {
            return Task.FromResult(Fail(ex));
        }

     

        

        public static IResult Success()
        {
            return new Result { Succeeded = true };
        }
        public static Task<IResult> SuccessAsync()
        {
            return Task.FromResult(Success());
        }

        public static IResult Success(string message)
        {
            return new Result { Succeeded = true, Messages = new List<string> { message } };
        }

        public static Task<IResult> SuccessAsync(string message)
        {
            return Task.FromResult(Success(message));
        }

        public static IResult Success(List<string> messages)
        {
            return new Result { Succeeded = true, Messages = messages };
        }

        public static Task<IResult> SuccessAsync(List<string> messages)
        {
            return Task.FromResult(Success(messages));
        }
    }

    public class Result<T> : Result, IResult<T>
    {
        public Result()
        {
        }

        public T Data { get; set; }

        public new static Result<T> Fail()
        {
            return new Result<T> { Succeeded = false };
        }
        public new static Task<Result<T>> FailAsync()
        {
            return Task.FromResult(Fail());
        }

        public new static Result<T> Fail(string error)
        {
            return new Result<T> { Succeeded = false, Errors = new List<string> { error } };
        }
        public new static Task<Result<T>> FailAsync(string error)
        {
            return Task.FromResult(Fail(error));
        }

        public new static Result<T> Fail(Exception ex)
        {
            return new Result<T> { Succeeded = false, Errors = new List<string> { ex.ToString() } };
        }
        public new static Task<Result<T>> FailAsync(Exception ex)
        {
            return Task.FromResult(Fail(ex));
        }

        public void AddError(string error   )
        {
            if (Errors == null) Errors = new();
            Errors.Add(error);
        }

        public new static Result<T> Fail(List<string> errors)
        {
            return new Result<T> { Succeeded = false, Errors = errors };
        }
        public new static Task<Result<T>> FailAsync(List<string> errors)
        {
            return Task.FromResult(Fail(errors));
        }


        public new static Result<T> Success()
        {
            return new Result<T> { Succeeded = true };
        }
        public new static Task<Result<T>> SuccessAsync()
        {
            return Task.FromResult(Success());
        }

        public new static Result<T> Success(string message)
        {
            return new Result<T> { Succeeded = true, Messages = new List<string> { message } };
        }
        public new static Task<Result<T>> SuccessAsync(string message)
        {
            return Task.FromResult(Success(message));
        }

        public static Result<T> Success(T data)
        {
            return new Result<T> { Succeeded = true, Data = data };
        }

        public static Task<Result<T>> SuccessAsync(T data)
        {
            return Task.FromResult(Success(data));
        }

        public static Result<T> Success(T data, string message)
        {
            return new Result<T> { Succeeded = true, Data = data, Messages = new List<string> { message } };
        }
        public static Task<Result<T>> SuccessAsync(T data, string message)
        {
            return Task.FromResult(Success(data, message));
        }

        public static Result<T> Success(T data, List<string> messages)
        {
            return new Result<T> { Succeeded = true, Data = data, Messages = messages };
        }

        public static Task<Result<T>> SuccessAsync(T data, List<string> messages)
        {
            return Task.FromResult(Success(data, messages));
        }






    }
}