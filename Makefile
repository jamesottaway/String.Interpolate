SOLUTION = String.Interpolate.sln
MAIN_PROJECT = Interpolate
TEST_PROJECT = Interpolate.Tests
CONFIGURATION = Release
VERSION = 0.0.1

.PHONY: all
all: clean build test

.PHONY: clean
clean:
	xbuild $(SOLUTION) /t:clean /p:Configuration=$(CONFIGURATION)

.PHONY: build
build:
	xbuild $(SOLUTION) /t:build /p:Configuration=$(CONFIGURATION)

.PHONY: test
test: build packages
	nunit $(TEST_PROJECT)/bin/$(CONFIGURATION)/$(TEST_PROJECT).dll

.PHONY: packages
packages:
	nuget restore $(SOLUTION)

.PHONY: nupkg
nupkg: build test
	nuget pack $(MAIN_PROJECT)/$(MAIN_PROJECT).nuspec

.PHONY: release
release: nupkg
	nuget push $(MAIN_PROJECT).$(VERSION).nupkg
