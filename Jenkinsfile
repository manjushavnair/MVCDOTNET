node ('master'){
	stage ('Checkout')
		git 'https://github.com/manjushavnair/MVCDOTNET.git'

	stage ('Build')
 		bat "\"${tool 'MSBuild'}\" MVCApp.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"

	stage ('Archive')
		archive 'MVCDOTNET/bin/Release/**'

}