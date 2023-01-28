if (args.Length > 0)
{
    HttpClient client = new HttpClient();

    client.DefaultRequestHeaders.Add("authorization", "Bearer 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")
}
else
{
    Console.WriteLine("---> You need to provide some input");
}