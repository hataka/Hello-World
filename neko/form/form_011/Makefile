### Makefile.gcc

all:
	@for subdir in *; do \
		if [ -d $$subdir ]; then \
			echo "processing folder $$subdir"; \
			cd $$subdir ; $(MAKE) ; cd .. ; \
		fi; \
		done;
		@echo "Done!"

win:
	@for subdir in cpp*; do \
		if [ -d $$subdir ]; then \
			echo "processing folder $$subdir"; \
			cd $$subdir ; $(MAKE) win ; cd .. ; \
		fi; \
		done;
		@echo "Done!"

clean:
	@for subdir in cpp*; do \
		if [ -d $$subdir ]; then \
			echo "processing folder $$subdir"; \
			cd $$subdir ; $(MAKE) clean ; cd .. ; \
		fi; \
		done;
		@echo "Done!"

