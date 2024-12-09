# AzureOpenAiClient

AzureOpenAiClient is a library designed to interact with Azure OpenAI services, providing functionalities to generate embeddings, interact with chat models, and perform other AI-driven tasks. This client enables seamless integration with Azure OpenAI APIs, simplifying complex AI operations in your applications.

## Table of Contents

1. [Introduction](#introduction)
2. [Features](#features)
3. [Tech Stack](#tech-stack)
4. [Usage](#usage)
5. [Configuration](#configuration)

## Introduction

AzureOpenAiClient provides an efficient way to leverage Azure OpenAI services, supporting functionalities like embedding generation and text analysis. It is optimized for integration into .NET applications, making it easy to incorporate AI capabilities into your workflows.

## Features

- **Generate Embeddings:** Convert text into numerical representations for use in vector databases or machine learning workflows.
- **Chat Models:** Interact with conversational AI models for generating responses to text inputs.
- **Customizable Options:** Configure API endpoint, deployment name, and API key via dependency injection.
- **Batch Processing:** Efficiently handle multiple inputs for embedding generation in a single operation.
- **Asynchronous Operations:** Fully asynchronous methods for seamless integration with modern .NET applications.

## Tech Stack

- **Backend:** .NET 8
- **Service:** Azure OpenAI
- **Dependency Injection:** Used for service registrations and configurations

## Usage

1. **Register the AzureOpenAiClient:** Use the `RegisterAzureOpenAiClient` extension method to register the client in the dependency injection container.
2. **Configure the options:** Set up `AzureOpenAiOptions` with the necessary configuration, including the endpoint URI, API key, and deployment name.
3. **Perform Operations:** Use methods such as `GetEmbeddingsAsync` to generate embeddings for provided text inputs.

## Configuration

### AzureOpenAiOptions

- **Endpoint:** The URI of the Azure OpenAI endpoint.
- **ApiKey:** The API key for authenticating with Azure OpenAI.
- **DeploymentName:** The name of the deployment to use for embeddings or other AI operations.

```csharp
public class AzureOpenAiOptions
{
    public string Endpoint { get; set; } = string.Empty;
    public string ApiKey { get; set; } = string.Empty;
    public string DeploymentName { get; set; } = string.Empty;
}
```