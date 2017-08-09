/*
This interface was created to enforce uniformity when creating classes that connect to the API endpoints. In the implementation, Agent, should always be "Sia-Agent"
and Address will vary with how siad is setup to run - however in most cases, siad is accessed locally.
*/
namespace simple_sia_library
{
    public interface IEndPoint
    {
        string Address { get; }     
    }
}