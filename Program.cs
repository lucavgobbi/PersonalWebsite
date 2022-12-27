await Bootstrapper
    .Factory
    .CreateWeb(args)
    .DeployToGitHubPagesBranch(
        "lucavgobbi",
        "lucavgobbi.github.io",
        Config.FromSetting<string>("GITHUB_TOKEN"),
        "main")
    .RunAsync()
    .ConfigureAwait(false);