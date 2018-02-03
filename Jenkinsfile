 pipeline {
 
	node ('master'){
	
	stages {
 
 	stage ('Checkout')
 	
 	steps {
	 
	 
	echo 'Checkout..'
 	git 'https://github.com/manjushavnair/MVCDOTNET.git'
	 
	}
 		
 
 	stage ('Build')
 	steps {
	 
	echo 'Building..'
	
		bat "\"${tool 'MSBuild'}\msbuild.exe" MVCApp\MVCApp.sln /p:Configuration=Release /p:Platform=\"Any CPU\" /p:ProductVersion=1.0.0.${env.BUILD_NUMBER}"
 	 
	}

  
 	stage ('Archive')
 	steps {
	 echo 'Archive..'
 		archive 'MVCDOTNET/bin/Release/**'
 		}

	 }
	 }
}
