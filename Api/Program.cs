using MinimalApi;

IHostBuilder CreateHostBuilder(string[] args){
  return Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<Startup>();
    });
}

CreateHostBuilder(args).Build().Run();
//app.UseSwagger();
//app.UseSwaggerUI();

//app.UseAuthentication();
//app.UseAuthorization();

//app.Run();