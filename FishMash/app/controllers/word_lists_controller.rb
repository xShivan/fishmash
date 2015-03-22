class WordListsController < ApplicationController

	# Displaying all lists
	def index
		@lists = WordList.all
	end

	# Displaying specific wordlist
	def show
		@list = WordList.find(params[:id])
	end
end