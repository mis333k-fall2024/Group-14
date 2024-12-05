using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Files.Utilities
{
    public static class SessionExtensions
    {
        // Serialize an object and store it in the session as a JSON string
        public static void SetObjectAsJson(this ISession session, string key, object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value), "Value cannot be null when setting session data.");
            }

            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        // Retrieve a JSON string from the session and deserialize it into an object
        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            if (string.IsNullOrEmpty(value))
            {
                return default; // Return default(T) if the key does not exist or value is null
            }

            try
            {
                return JsonConvert.DeserializeObject<T>(value);
            }
            catch (JsonException ex)
            {
                throw new InvalidOperationException($"Failed to deserialize session value for key '{key}' into type {typeof(T).Name}.", ex);
            }
        }

        // Remove a key from the session
        public static void RemoveObject(this ISession session, string key)
        {
            session.Remove(key);
        }
    }
}
