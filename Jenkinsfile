pipeline {
  agent any
  stages {
	stage ('Start build')
	{
		steps {
		echo 'Start build..'
		}
	}
	stage ('Checkout')
	{
		steps {
		echo 'Checkout..'
		git 'https://github.com/manjushavnair/MVCDOTNET.git'
		}
	}
  }
}