 pipeline {
 
 
	  agent any
	  {
	  }
	  options
	  {
	  }

	
	stages {



 	stage ('Start build')
 	
 	steps {
	 
	 
	echo 'Start build..'
 	}

 
 	stage ('Checkout')
 	
 	steps {
	 
	 
	echo 'Checkout..'
 	git 'https://github.com/manjushavnair/MVCDOTNET.git'
	 
	}
 		
 
 	stage ('Build')
 	steps {
	 
		echo 'Building..'

		bat "C:\\Program Files (x86)\\MSBuild\\14.0\\Bin\\msbuild.exe MVCApp\\MVCApp.sln /p:Configuration=Release /p:Platform=\"Any CPU\""
 	 
	}

  
 	stage ('Archive')
 	steps {
		 echo 'Archive..'
 		archive 'MVCDOTNET/bin/Release/**'
 		}

	 }
	 
	 
}
