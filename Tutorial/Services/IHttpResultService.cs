﻿using System.Text.Json;

namespace Tutorial.Services
{
    public interface IHttpResultService
    {
        Task<string?> ReadAsStringAsync(CancellationToken cancellationToken = default);
        Task<TResponse?> ReadFromJsonAsync<TResponse>(JsonSerializerOptions? options = null, CancellationToken cancellationToken = default);
        Task<Stream?> ReadAsStreamAsync(CancellationToken cancellationToken = default);
        Task<byte[]> ReadAsByteArrayAsync(CancellationToken cancellationToken = default);
    }
}
