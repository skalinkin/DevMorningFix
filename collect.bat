
If Not exist .\Source\ExploringContainers\conanbuildinfo_release_x64_v141.props (
	conan install -if .\Source\ExploringContainers .\Source\ExploringContainers
	copy /b DevMorningFix.sln +,, 
)