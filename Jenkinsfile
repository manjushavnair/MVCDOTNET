pipeline {
agent any
 

stages {
	stage ('Start build')
	{
		steps {
		echo 'Start build..'
		bat .\.nuget\nuget.exe restore .\MVCApp\MVCApp.sln

		
		}
	}
	stage ('Checkout')
	{
		steps {
		echo 'Checkout..'
		git 'https://github.com/manjushavnair/MVCDOTNET.git'
		}
	}
	stage ('Build')
	{
		steps {
		echo 'Building..'
		bat "\"C:/Program Files (x86)/MSBuild/14.0/Bin/msbuild.exe\" MVCApp/MVCApp.sln /p:Configuration=Release /p:Platform=\"Any CPU\""
		}
	}
}
}
