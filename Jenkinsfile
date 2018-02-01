 

#!/usr/bin/env groovy
// Declarative //
pipeline {
 
	node ('master'){
 
 	stage ('Checkout')
 	
 	steps {
	 
	echo 'Checkout..'
	git config --system core.longpaths true
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
